import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

   nrr: number = 0;
   cuvant: string='liga';
   leagues = [];
   curentLeagues=[];
   matches = []; 

   

  constructor() { }

  ngOnInit() {
    this.hardCodateTheInput();
    this.curentLeagues=this.leagues;
  }

  putTheGoodContent(league){
     //vom cauta toate maciurile pentru liga data
     this.curentLeagues=null;
     this.matches=null;
    
  }

  getAndSetMatches(league){
     
  }

  getMatchesByLeague(){

  }

  setMatches(){
    
  }



  hardCodateTheInput(){

    this.leagues.push({'name':'Bundes Liga','flag':'https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/1200px-Flag_of_Romania.svg.png'});
  
    this.leagues.push({'name':'La Liga','flag':'https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/1200px-Flag_of_Romania.svg.png'});
  
    this.leagues.push({'name':'Premier League','flag':'http://www.footballtop.com/sites/default/files/styles/width200/public/photos/championship/barclays.jpg?itok=acRHBH58'});
  
    this.leagues.push({'name':'Liga 1','flag':'https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/1200px-Flag_of_Romania.svg.png'});
    

    this.matches.push({'ora':'17:30','homeTeam':'Barcelone','homeTeamFlag':'http://icons.iconarchive.com/icons/giannis-zographos/spanish-football-club/256/FC-Barcelona-icon.png',
                        'awayTeamFlag':'http://icons.iconarchive.com/icons/giannis-zographos/spanish-football-club/256/FC-Barcelona-icon.png','awayTeam':'Real Madrid',
                      'awayGoals':'0','homeGoals':'3'});

    this.matches.push({'ora':'17:30','homeTeam':'Barcelone','homeTeamFlag':'http://icons.iconarchive.com/icons/giannis-zographos/spanish-football-club/256/FC-Barcelona-icon.png',
    'awayTeamFlag':'http://icons.iconarchive.com/icons/giannis-zographos/spanish-football-club/256/FC-Barcelona-icon.png','awayTeam':'Real Madrid',
  'awayGoals':'0','homeGoals':'3'});

  this.matches.push({'ora':'17:30','homeTeam':'Barcelone','homeTeamFlag':'http://icons.iconarchive.com/icons/giannis-zographos/spanish-football-club/256/FC-Barcelona-icon.png',
  'awayTeamFlag':'http://icons.iconarchive.com/icons/giannis-zographos/spanish-football-club/256/FC-Barcelona-icon.png','awayTeam':'Real Madrid',
'awayGoals':'0','homeGoals':'3'});
  }

}
