import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {BookCard} from "../models/BookCard";

@Component({
  selector: 'app-mini-admin-table',
  templateUrl: './mini-admin-table.component.html',
  styleUrls: ['./mini-admin-table.component.css']
})
export class MiniAdminTableComponent implements OnInit {

  constructor() { }
  @Input()
  pagedBook:BookCard[]
  @Output()
  pagedBookChange:EventEmitter<BookCard[]> = new EventEmitter<BookCard[]>();
  ngOnInit(): void {

  }


  save() {
    console.log("???")
    this.pagedBookChange.emit(this.pagedBook);
  }


}
