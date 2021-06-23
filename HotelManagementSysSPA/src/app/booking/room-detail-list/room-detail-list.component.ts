import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from "@angular/router";
import {RoomService} from "../../core/services/RoomService";
import {BookCard} from "../../shared/models/BookCard";

@Component({
  selector: 'app-room-detail-list',
  templateUrl: './room-detail-list.component.html',
  styleUrls: ['./room-detail-list.component.css']
})
export class RoomDetailListComponent implements OnInit {

  constructor(private route: ActivatedRoute,private rooomService:RoomService) { }
  id:number;
  bookCard:BookCard
  ngOnInit(): void {
    this.route.paramMap.subscribe(params=>{
      this.id=Number(params.get('id'));

      console.log(this.id);
      this.rooomService.getOneBookedRoom(this.id).subscribe(m=>{this.bookCard=m;console.log(this.bookCard)}
      )
    })

  }
}
