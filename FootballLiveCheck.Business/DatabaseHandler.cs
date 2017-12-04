using AutoMapper;
using EnsureThat;

namespace FootballLiveCheck.Business
{
    public abstract class DatabaseHandler
    {
        protected IMapper Mapper { get; }

        protected DatabaseHandler(IMapper mapper)
        {
            EnsureArg.IsNotNull(mapper);
            Mapper = mapper;
        }
    }
}