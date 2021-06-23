import {Component, Input, OnInit} from '@angular/core';
import {RoomCardModel} from "../../shared/models/RoomCardModel";
import {BookCard} from "../../shared/models/BookCard";
import {RoomService} from "../../core/services/RoomService";
import {pipe} from "rxjs";

@Component({
  selector: 'app-room-book-card',
  templateUrl: './room-book-card.component.html',
  styleUrls: ['./room-book-card.component.css']
})
export class RoomBookCardComponent implements OnInit {

  constructor(private roomService:RoomService) { }


  bookCards!:BookCard[]
  ngOnInit(): void {

    this.roomService.getBookedRoomCards().subscribe(m => {
      this.bookCards = m
    });
    console.log(this.bookCards);
  }


}
