import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { SharedserviceProvider } from '../../app/sharedservice';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  sum: number = 0;
  answer: string;
  constructor(public navCtrl: NavController, private svc: SharedserviceProvider) {
  }

  getAnswer()
  {
    var ans = this.svc.getItems(this.sum).subscribe(data =>this.answer = data, err => console.log(err));
  }
}
