import { Component, OnInit } from '@angular/core';
import {RoomCardModel} from "../../shared/models/RoomCardModel";

import {RoomService} from "../../core/services/RoomService";
import {ActivatedRoute} from "@angular/router";



@Component({
  selector: 'app-availables',
  templateUrl: './availables.component.html',
  styleUrls: ['./availables.component.css']
})
export class AvailablesComponent implements OnInit {

  constructor(private roomService:RoomService,private route: ActivatedRoute) { }
  rooms!: RoomCardModel[];

  nextUrl:string;
  id:number= 0;
  ngOnInit(): void {


    this.getAvailables();
    if(this.id!=0){
      this.roomService.getAvailableRoomCardsForType(this.id).subscribe(m=>this.rooms=m);
      return;
    }
      this.roomService.getAvailableRoomCards().subscribe(m => {
        this.rooms=m;
      });

      return

  }

  getAvailables(){
    this.route.paramMap.subscribe(
      params => {

        this.id = Number(params.get('id'));


      }
    )

  }




}
