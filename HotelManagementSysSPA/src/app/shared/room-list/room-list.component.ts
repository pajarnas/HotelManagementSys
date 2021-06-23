import {Component, Input, OnInit} from '@angular/core';
import {BookCard} from "../models/BookCard";
import Swal from 'sweetalert2/dist/sweetalert2.js';
import {HotelService} from "../../core/services/HotelService";
import {HotelServices} from "../models/HotelServices";
import {pipe} from "rxjs";
import {ServiceTypes} from "../models/ServiceTypes";

@Component({
  selector: 'app-room-list',
  templateUrl: './room-list.component.html',
  styleUrls: ['./room-list.component.css']
})
export class RoomListComponent implements OnInit {

  constructor( private hotelService:HotelService) {

  }



  hotelServices:ServiceTypes[]
  @Input()
  bookCard:BookCard;
  ngOnInit(): void {
   this.hotelService.getAllServiceTypes().subscribe(m=>this.hotelServices=m);
  }

  simpleAlert(){
    Swal.fire('Hello Angular');
  }

  alertWithSuccess(){
    Swal.fire('Thank you...', 'You submitted succesfully!', 'success')
  }
  erroalert()
  {
    Swal.fire({
      icon: 'error',
      title: 'Oops...',
      text: 'Something went wrong!',
      footer: '<a href>Why do I have this issue?</a>'
    })
  }
  topend()
  {
    Swal.fire({
      position: 'top-end',
      icon: 'success',
      title: 'Your work has been saved',
      showConfirmButton: false,
      timer: 1500
    })
  }
  minxin(){
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
  confirmBox(){
    Swal.fire({
      title: 'Are you sure want to remove?',
      text: 'You will not be able to recover this file!',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, delete it!',
      cancelButtonText: 'No, keep it'
    }).then((result) => {
      if (result.value) {
        Swal.fire(
          'Deleted!',
          'Your imaginary file has been deleted.',
          'success'
        )
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire(
          'Cancelled',
          'Your imaginary file is safe :)',
          'error'
        )
      }
    })}

  }
