import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { environment } from '../../../environments/environment';
import { RoomCardModel } from '../../shared/models/RoomCardModel';
import {RoomTypeCardModel} from "../../shared/models/RoomTypeCardModel";
import {BookCard} from "../../shared/models/BookCard";
import {HotelServices} from "../../shared/models/HotelServices";
import {ServiceTypes} from "../../shared/models/ServiceTypes";



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




}
