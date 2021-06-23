import {Component, Input, OnInit} from '@angular/core';
import {BookCard} from "../models/BookCard";

@Component({
  selector: 'app-mini-book-card',
  templateUrl: './mini-book-card.component.html',
  styleUrls: ['./mini-book-card.component.css']
})
export class MiniBookCardComponent implements OnInit {
  @Input()
  bookCard!:BookCard
  constructor() { }
  roomUrl = './assets/img/hotel/'+ 'default.jpg';
  baseUrl = './assets/img/hotel/';

  ngOnInit(): void {
    this.populate();
  }
  populate(){

    switch (this.bookCard.roomTypeId){
      case 1:
        this.roomUrl = this.baseUrl + 'low-cost0.jpg';

        break;
      case 2:
        this.roomUrl = this.baseUrl + 'low-cost1.jpg';


        break;
      case 3:
        this.roomUrl = this.baseUrl + 'medium0.jpeg';


        break;
      case 4:
        this.roomUrl = this.baseUrl + 'default.jpg';


        break;
      case 5:
        this.roomUrl = this.baseUrl + 'hight-class0.jpg';

        break;
      case 6:
        this.roomUrl = this.baseUrl + 'hight-class1.jpg';

        break;
      default:
        this.roomUrl = this.baseUrl + 'default.jpg';


    }}
}
