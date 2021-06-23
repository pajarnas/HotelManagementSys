import { Component, OnInit } from '@angular/core';
import {RoomTypeCardModel} from "../../shared/models/RoomTypeCardModel";
import {RoomService} from "../../core/services/RoomService";

@Component({
  selector: 'app-types',
  templateUrl: './types.component.html',
  styleUrls: ['./types.component.css']
})
export class TypesComponent implements OnInit {
  types!: RoomTypeCardModel[];
  constructor(private roomService: RoomService) { }

  ngOnInit(): void {
    this.roomService.getTypes().subscribe(m => {
    this.types = m
  });
  }

}
