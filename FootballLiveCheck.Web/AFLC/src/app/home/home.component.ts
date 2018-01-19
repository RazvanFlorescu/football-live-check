import { Component, OnInit } from '@angular/core';
import {Http, Response, Headers} from '@angular/http';
import 'rxjs/add/operator/toPromise';
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

   leagues =[];
   matches = []; 
   liveMatches = []; 
   currentMatches = []; 
   currentLeagues = [];
   leagueId:number;
   show:number=1;
   matchId:number;
   homeTeam:string;
   awayTeam:string;
   homeGoals:number;
   awayGoals:number;
   leagueName:number;
   homeShirtUrl:string;
   awayShirtUrl:string;
   arenaName:string;
   arenaCapacity:string;
   email:string;
   idMatch:number;
   link :string;
   date:string
   response:string='Mail was send!'
   subscribedMatches =[];

  constructor(private http: Http) { }
  id:number;
  private headers = new Headers({ 'Content-Type': 'application/json', 'Access-Control-Allow-Origin': '*'});


  getAllLeagues() {   
    this.http.get("http://localhost:5001/api/leagues/topleagues").subscribe(
      (res: Response) => {
        this.leagues = res.json()['leagues'];
        this.currentLeagues=res.json()['leagues'];
      }
    )
             
  }

  getAllLiveMatches(){
    this.http.get("http://localhost:5001/api/matches/live").subscribe(
      (res: Response) => {
        this.liveMatches = res.json()['matches'];
      
      }
    )
    
  }
 
  getFullTimeMatchesByLeague(leagueId ){
    var leagueIdString = ""+leagueId; 
    this.link = "http://localhost:5001/api/matches/fulltime/"+leagueIdString;
  
      this.http.get(this.link).subscribe(
        (res: Response) => {
         
          this.currentMatches = res.json()['matches'];
        }
      )
      this.show=1;
  }
  getUpcomingMatchesByLeague(leagueId ){
    var leagueIdString = ""+leagueId; 
    this.link = "http://localhost:5001/api/matches/upcoming/"+leagueIdString;
    this.http.get(this.link).subscribe(
      (res: Response) => {
       
        this.currentMatches = res.json()['matches'];
      }
    )
    this.show=1;
  }

  modifyDate(date){
    var data = new Date(date);
    return data.getHours() + ":" + data.getMinutes();
  }

  
  
  makeSubscribe(homeTeam,awayTeam,homeGoals,awayGoals,leagueName,homeShirtUrl,awayShirtUrl,arena,idMatch){
    this.show=0;
    this.awayTeam=awayTeam;
    this.homeTeam=homeTeam;
    this.homeGoals=homeGoals;
    this.awayGoals=awayGoals;
    this.leagueName=leagueName;
    this.matchId=idMatch;
    this.homeShirtUrl=homeShirtUrl;
    this.awayShirtUrl=awayShirtUrl;
    if(arena !=null){
      this.arenaName=arena.name;
      this.arenaCapacity=arena.capacity;
    }
    else{
      this.arenaName="No data about this arena";
      this.arenaCapacity="No data about arena capacity";
    }
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
  
    this.http.post("http://localhost:5001/api/subscribe", this.productObj).subscribe((res:Response) => {
      this.isAdded = true;
    })
    this.show=1;
  }

  getAllSubscribedMatches(){
    this.http.get("http://localhost:5001/api/subscribe").subscribe(
      (res: Response) => {
        this.subscribedMatches = res.json()['subscriptions'];
      }
    )
    
  }


  isSubscribedMatch(matchId){
    for (var i = 0; i < this.subscribedMatches.length; i++) {
      if(this.subscribedMatches[i].subscribedMatch.dbId == matchId){
        return true;
      }
  }
  return false;
  
  }


  getSubscriptionIdByMatchId(matchId){
    for (var i = 0; i < this.subscribedMatches.length; i++) {
      if(this.subscribedMatches[i].subscribedMatch.dbId == matchId){
        return this.subscribedMatches[i].id;
      }
    }
  }

  unSubscribeFromMatch(matchId){
    var subscriptionId = this.getSubscriptionIdByMatchId(matchId);
    this.productObj = {
        "id" : subscriptionId
    }
    this.http.delete("http://localhost:5001/api/subscribe",this.productObj).toPromise();
    this.show=0;
  }

  
  ngOnInit() {
    this.getAllLiveMatches();
    this.getAllLeagues();
    this.getAllLiveMatches();
    this.getAllSubscribedMatches();
  }






}
