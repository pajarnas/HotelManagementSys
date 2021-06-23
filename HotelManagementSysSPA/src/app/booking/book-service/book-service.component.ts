import {Component, Input, OnInit} from '@angular/core';
import {HotelService} from "../../core/services/HotelService";
import {HotelServices} from "../../shared/models/HotelServices";
import {BookCard} from "../../shared/models/BookCard";
import Swal from 'sweetalert2/dist/sweetalert2.js';
import {ServiceTypes} from "../../shared/models/ServiceTypes";
import {ActivatedRoute} from "@angular/router";
import {RoomService} from "../../core/services/RoomService";
import {pipe} from "rxjs";
@Component({
  selector: 'app-book-service',
  templateUrl: './book-service.component.html',
  styleUrls: ['./book-service.component.css']
})
export class BookServiceComponent implements OnInit {

  constructor( private hotelService:HotelService,private route: ActivatedRoute,private rooomService:RoomService) {

  }



  hotelServices!:ServiceTypes[]
  id!:number;
  bookCard!:BookCard;
  ngOnInit(): void {

    this.hotelService.getAllServiceTypes().subscribe((m=>this.hotelServices=m))
    this.route.paramMap.subscribe(params=>{
      this.id=Number(params.get('id'));


      this.rooomService.getOneBookedRoom(this.id).subscribe(m=>{this.bookCard=m;console.log(this.bookCard)}

      )
    })

  }

  minxin(id:number){

     //add data to database

    console.log(id);
    const Toast = Swal.mixin({
      toast: true,
      position: 'top-end',
      showConfirmButton: false,
      timer: 3000,
      timerProgressBar: true,
      didOpen: (toast) => {
        toast.addEventListener('mouseenter', Swal.stopTimer)
        toast.addEventListener('mouseleave', Swal.resumeTimer)
      }
    })

    Toast.fire({
      icon: 'success',
      title: 'Signed in successfully'
    })
  }

}
