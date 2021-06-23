import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { environment } from '../../../environments/environment';
import { RoomCardModel } from '../../shared/models/RoomCardModel';
import {RoomTypeCardModel} from "../../shared/models/RoomTypeCardModel";
import {BookCard} from "../../shared/models/BookCard";
import {HotelServices} from "../../shared/models/HotelServices";
import {ServiceTypes} from "../../shared/models/ServiceTypes";
import {BookRequest} from "../../shared/models/BookRequest";
import {RoomServiceRequest} from "../../shared/models/RoomServiceRequest";



@Injectable({
  providedIn: 'root'
})
export class HotelService {


  constructor(private http: HttpClient) {
  }


  getAllServices(): Observable<HotelServices[]> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'RoomService/roomservices'}`)
      .pipe(map(resp => resp as HotelServices[]))

  }


  getAllServiceTypes(): Observable<ServiceTypes[]> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'RoomService/servicetypes'}`)
      .pipe(map(resp => resp as ServiceTypes[]))

  }

  postService(book:RoomServiceRequest ): Observable<boolean> {
    //  call the API to get the json data

    let headers: HttpHeaders;
    headers = new HttpHeaders();
    console.log("Asdasdasasd")

    headers.append('Content-Type', 'application/json');
    return this.http.post(`${environment.apiUrl}${'RoomService/addservice'}`, book,{headers:headers})
      .pipe(map((resp:any) =>
      {

        return true;
      }));
  }

    //  call the API to get the json data




}
