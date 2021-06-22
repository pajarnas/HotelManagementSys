import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { environment } from '../../../environments/environment';
import { RoomCardModel } from '../../shared/models/RoomCardModel';
import {RoomTypeCardModel} from "../../shared/models/RoomTypeCardModel";



@Injectable({
  providedIn: 'root'
})
export class RoomService {


  constructor(private http: HttpClient) {
  }


  getRoomCards(): Observable<RoomCardModel[]> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'Room/rooms'}`)
      .pipe(map(resp => resp as RoomCardModel[]))

  }

  getAvailableRoomCards(): Observable<RoomCardModel[]> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'Room/availables'}`)
      .pipe(map(resp => resp as RoomCardModel[]))

  }

  getTypes(): Observable<RoomTypeCardModel[]> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'Room/types'}`)
      .pipe(map(resp => resp as RoomTypeCardModel[]))

  }

  getAvailableRoomCardsForType(id:number): Observable<RoomCardModel[]> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'Room/availables/'}${id}`)
      .pipe(map(resp => resp as RoomCardModel[]))

  }

  getAvailableRoomCardsById(id:number): Observable<RoomCardModel> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'Room/'}${id}`)
      .pipe(map(resp => resp as RoomCardModel))

  }



  }
