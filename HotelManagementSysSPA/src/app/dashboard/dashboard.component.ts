import { Component, OnInit,AfterViewInit } from '@angular/core';
import * as Chartist from 'chartist';
import {RoomService} from "../core/services/RoomService";
import {RoomCardModel} from "../shared/models/RoomCardModel";
import {Location} from "@angular/common";
import {RoomTypeCardModel} from "../shared/models/RoomTypeCardModel";

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit,AfterViewInit {

  constructor(private roomService: RoomService, private location: Location) {
  }

  rooms!: RoomCardModel[];
  types!: RoomTypeCardModel[];
  isType: boolean = false;
  nextUrl:string;
  ngAfterViewInit() {


  }

  ngOnInit() {

    var titlee = this.location.prepareExternalUrl(this.location.path());

    titlee = titlee.split('/', 3)[2]

    if (titlee == 'Available') {
      this.isType = false;

      this.roomService.getAvailableRoomCards().subscribe(m => {
          this.rooms=m;
      });
      console.log('aaaaa')
      return
    }

    titlee = this.location.prepareExternalUrl(this.location.path()).split('/', 4)[3];

    if (titlee != null) {
      console.log('ttttt')
      this.isType = false;
      this.roomService.getAvailableRoomCardsForType(Number(titlee)).subscribe(m => {
        this.rooms = m
      });
      return
    }
    titlee = this.location.prepareExternalUrl(this.location.path());
    console.log(titlee)
    if(titlee=='/') this.nextUrl=titlee+'/rooms/Types/'
    if(titlee=='/rooms') this.nextUrl=titlee+'/Types/'
    if(titlee=='/rooms/Types') this.nextUrl=titlee+'/'

    this.isType = true;
    this.roomService.getTypes().subscribe(m => {
      this.types = m
    });
    return
  }
}
