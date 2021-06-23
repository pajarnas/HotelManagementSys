import {Component, Input, OnInit} from '@angular/core';
import {BookCard} from "../models/BookCard";
import {RoomService} from "../../core/services/RoomService";
import {pipe} from "rxjs";
import {map} from "rxjs/operators";

@Component({
  selector: 'app-bills-list',
  templateUrl: './bills-list.component.html',
  styleUrls: ['./bills-list.component.css']
})
export class BillsListComponent implements OnInit {

  constructor( ) { }
  @Input()
  bookCard:BookCard;
  ngOnInit(): void {

  }

}
