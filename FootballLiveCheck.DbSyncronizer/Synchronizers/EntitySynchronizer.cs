using System.Linq;
using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.MappingProfiles;
using FootballLiveCheck.CqrsCore.DependencyInjection;
using FootballLiveCheck.DbSynchronizer.Mappers;
using FootballLiveCheck.DbSynchronizer.Shared;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Interfaces;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.DbSynchronizer.Synchronizers
{
    public class EntitySynchronizer<TEntity, TJson> : BaseSynchronizer, IEntitySynchronizer<TEntity, TJson>
        where TEntity : ApiEntity
        where TJson : BaseJsonObject
    {
        private readonly IJsonMapper<TEntity, TJson> mapper;
        private readonly IBaseApiRepository<TEntity> repository;

        public EntitySynchronizer(IBaseApiRepository<TEntity> repository, IJsonMapper<TEntity, TJson> mapper)
        {
            EnsureArg.IsNotNull(repository);
            EnsureArg.IsNotNull(mapper);
            this.repository = repository;
            this.mapper = mapper;
        }


        public void Synchronize(string endPoint)
        {
            var json = URLToJSONConverter.GetJSONString(RequestUrl(endPoint));
            var allEntities = repository.GetAll();
            var allJsonObjects = JSONDeserializer.DeserializeAsList<TJson>(json);


            var entitiesToInsert = allJsonObjects.Where(e => !allEntities.Any(de => de.DbId == e.DbId));

            foreach (var jEntity in entitiesToInsert)
            {
                var entity = mapper.Map(jEntity);
                ////entity.SetId(jEntity.DbId);
                repository.Add(entity);
            } //insert new Entities from Api


            var entitiesToDelete = allEntities.Where(de => allJsonObjects.All(e => de.DbId != e.DbId));
            foreach (var entity in entitiesToDelete)
                repository.Delete(entity);
            //delete entities that don't apear in ApTi

            var entitiesToUpdate =
                allJsonObjects.Where(ae => allEntities.Any(de => de.DbId == ae.DbId && !de.Equals(ae)));
            foreach (var entity in entitiesToUpdate)
            {
                var league = repository.GetById(entity.DbId);
                repository.Update(league);
            } //update entities that changed their status 

            repository.SaveChanges();
        }

        public string RequestUrl(string endPoint)
        {
            return BaseURL + endPoint + "?api_key=" + APIKey;
        }
    }
}