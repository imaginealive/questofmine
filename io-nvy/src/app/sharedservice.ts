import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/timeout';

/*
  Generated class for the SharedserviceProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class SharedserviceProvider {

  constructor(public http: HttpClient) {
    console.log('Hello SharedserviceProvider Provider');
  }

  getItems(sum: number){
    let headers = new HttpHeaders({
      'Content-Type': 'application/json'
    });
    return this.http.get('http://localhost:5000/api/calculate/' + sum, {headers: headers, responseType: 'text'});
  }
}
