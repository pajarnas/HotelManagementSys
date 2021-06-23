import { Component, OnInit } from '@angular/core';
import {Observable} from "rxjs";
import {BookCard} from "../../shared/models/BookCard";
import {ActivatedRoute} from "@angular/router";
import {RoomService} from "../../core/services/RoomService";

@Component({
  selector: 'app-book-bills',
  templateUrl: './book-bills.component.html',
  styleUrls: ['./book-bills.component.css']
})
export class BookBills implements OnInit {

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
