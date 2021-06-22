import {Component, Input, OnInit} from '@angular/core';
import {RoomCardModel} from "../models/RoomCardModel";

@Component({
  selector: 'app-room-card',
  templateUrl: './room-card.component.html',
  styleUrls: ['./room-card.component.css']
})
export class RoomCardComponent implements OnInit {

  roomUrl = './assets/img/hotel/'+ 'default.jpg';
  baseUrl = './assets/img/hotel/';
  constructor() { }
  @Input()
  roomCard!:RoomCardModel
  ngOnInit(): void {
    this.getRoomUrl();
  }

  getRoomUrl(){

    switch (this.roomCard.roomTypeId){
      case 1:
        this.roomUrl = this.baseUrl + 'low-cost0.jpg';
        break;
      case 2:
        this.roomUrl = this.baseUrl + 'low-cost0.jpg';
        break;
      case 3:
        this.roomUrl = this.baseUrl + 'medium0.jpeg';
        break;
      case 4:
        this.roomUrl = this.baseUrl + 'low-medium1.jpeg';
        break;
      case 5:
        this.roomUrl = this.baseUrl + 'hight-class0.jpg';
        break;
      case 6:
        this.roomUrl = this.baseUrl + 'hight-class1.jpg';
        break;
      default:
        this.roomUrl = this.baseUrl + 'default.jpg';

    }
  }

}
