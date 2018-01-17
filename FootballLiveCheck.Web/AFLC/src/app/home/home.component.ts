import { Component, OnInit } from '@angular/core';
import {Http, Response, Headers} from '@angular/http';
import 'rxjs/add/operator/toPromise';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

   leagues = [];
   matches = []; 
   curentLeagues = [];
   leagueId:number;
   show:number=1;
   homeTeam:string;
   awayTeam:string;
   homeGoals:number;
   awayGoals:number;
   leagueName:number;
   homeShirtUrl:string;
   awayShirtUrl:string;
   arenaName:string;
   arenaCapacity:number;
   email:string;
   idMatch:number;
   
   response:string='Mail was send!'
   

  constructor(private http: Http) { }
  id:number;
  private headers = new Headers({ 'Content-Type': 'application/json'});


  getAllLeagues() {
    this.http.get("http://localhost:5001/api/leagues/topleagues").subscribe(
      (res: Response) => {
        this.leagues = res.json();
        this.curentLeagues = res.json();
      }
    )
  }

  getAllMatches(){
    this.http.get("http://localhost:5001/api/matches/live").subscribe(
      (res: Response) => {
        this.matches = res.json();
        
      }
    )
    
  }
 
  getMatchesByLeague(league ){
    this.http.get("http://localhost:5554/matches").subscribe(
      (res: Response) => {
        this.matches = res.json();
      
      }
    )
    this.show=1;
  }

  makeSubscribe(homeTeam,awayTeam,homeGoals,awayGoals,leagueName,homeShirtUrl,awayShirtUrl,arenaName,arenaCapacity,idMatch){
    this.show=0;
    this.awayTeam=awayTeam;
    this.homeTeam=homeTeam;
    this.homeGoals=homeGoals;
    this.awayGoals=awayGoals;
    this.leagueName=leagueName;
    this.homeShirtUrl=homeShirtUrl;
    this.awayShirtUrl=awayShirtUrl;
    this.arenaName=arenaName;
    this.arenaCapacity=arenaCapacity;
    this.idMatch=idMatch;
  }

  isAdded: boolean = false;
  productObj:object = {};

  addSubscribedMatch(matchId,email) {
    this.productObj = {
	  "mail" :email,
	  "subscribedMatch":
	  {
 
	    "dbid" : matchId
 
	  }
      
    }
  
    this.http.post("http://localhost:5553/subscribed", this.productObj).subscribe((res:Response) => {
      this.isAdded = true;
    })
    this.show=1;
  }

  ngOnInit() {
    
    this.getAllMatches();
    this.getAllLeagues();

  }






}
