import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

   nrr: number = 0;
   cuvant: string='liga';
   strs = [];

  constructor() { }

  ngOnInit() {
    
  }


  addItem(){
    var a = this.cuvant + this.nrr.toString()
    this.strs.push(a);
    this.nrr++;
  }
}
