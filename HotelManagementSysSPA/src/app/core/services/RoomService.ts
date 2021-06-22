import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { environment } from '../../../environments/environment';
import { RoomCardModel } from '../../shared/models/RoomCardModel';



@Injectable({
  providedIn: 'root'
})
export class RoomService {


  constructor(private http: HttpClient) {
  }


  getMovieCards(): Observable<RoomCardModel[]> {
    //  call the API to get the json data

    return this.http.get(`${environment.apiUrl}${'Room/rooms'}`)
      .pipe(map(resp => resp as RoomCardModel[]))

  }
}
