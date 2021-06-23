import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { environment } from '../../../environments/environment';
import { RoomCardModel } from '../../shared/models/RoomCardModel';
import {RoomTypeCardModel} from "../../shared/models/RoomTypeCardModel";
import {BookCard} from "../../shared/models/BookCard";
import {BookRequest} from "../../shared/models/BookRequest";



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

  getBookedRoomCards(): Observable<BookCard[]> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'Room/books'}`)
      .pipe(map(resp => resp as BookCard[]))

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

  getRandomAvailableRoomCardsById(id:number): Observable<RoomCardModel> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'Room/tpyer/'}${id}`)
      .pipe(map(resp => resp as RoomCardModel))

  }


  getOneBookedRoom(id:number):Observable<BookCard>{
    return this.http.get(`${environment.apiUrl}${'Room/Rooms/BookedRoom/'}${id}`).pipe(map(resp=>resp as BookCard));
  }

  getPagedBooking(index:number,size:number):Observable<BookCard[]>{
      return this.http.get(`${environment.apiUrl}${'Room/Rooms/PagedRoom/'}${index}/${size}`).pipe(map(resp=>resp as BookCard[]));
  }





}
