import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { environment } from '../../../environments/environment';
import { RoomCardModel } from '../../shared/models/RoomCardModel';
import {RoomTypeCardModel} from "../../shared/models/RoomTypeCardModel";
import {BookRequest} from "../../shared/models/BookRequest";



@Injectable({
  providedIn: 'root'
})
export class CustomerService {


  constructor(private http: HttpClient) {
  }




  postBooking(book:BookRequest ): Observable<boolean> {
    //  call the API to get the json data

    let headers: HttpHeaders;
    headers = new HttpHeaders();
    headers.append('Content-Type', 'application/json');
    return this.http.post(`${environment.apiUrl}${'Customer/book'}`, book)
      .pipe(map((resp:any) =>
      {

        return true;
      }));
  }





}
