import { Component, OnInit } from '@angular/core';
import {RoomService} from "../../core/services/RoomService";
import {RoomBookCardComponent} from "../../booking/room-book-card/room-book-card.component";
import {BookCard} from "../../shared/models/BookCard";
import Swal from 'sweetalert2/dist/sweetalert2.js';
import {CustomerService} from "../../core/services/CustomerService";
import {ActivatedRoute,Router} from "@angular/router";
import {RoomCardModel} from "../../shared/models/RoomCardModel";
@Component({
  selector: 'app-hotel-service-management',
  templateUrl: './hotel-service-management.component.html',
  styleUrls: ['./hotel-service-management.component.css']
})
export class HotelServiceManagementComponent implements OnInit {

  constructor(private route :Router,private roomService:RoomService,private customerService:CustomerService) { }
  pageSize:number = 10;
  index :number = 1;
  pagedBook:BookCard[]  ;
  ngOnInit(): void {
    this.roomService.getBookedRoomCards().subscribe(m=>this.pagedBook=m);

  }
  onChangePage(pageOfItems: Array<any>) {
    // update current page of items
    this.roomService.getBookedRoomCards().subscribe(m=>this.pagedBook=m);
  }

  delete(id:number) {

    Swal.fire({
      title: 'Are you sure want to remove this Booking?',
      text: 'You will not be able to recover this record!',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, delete it!',
      cancelButtonText: 'No, keep it'
    }).then((result) => {
      if (result.value) {
        this.customerService.deleteBooking(id).subscribe();
        Swal.fire(

          'Deleted!',
          `The booking is removed, the room ${id} is available now.`,
          'success'
        )
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire(
          'Cancelled',
          'Your record is safe :)',
          'error'
        )
      }
    })







  }
  edit(id:number) {

    this.roomService.getRandomAvailableRoomCardsById(id).subscribe(m=>this.ranRoomId=m.id);

    this.route.navigate(['/books/',this.ranRoomId]);
  }


ranRoomId:number;

add(id:number){

    this.roomService.getRandomAvailableRoomCardsById(id).subscribe(m=>this.ranRoomId=m.id);

   this.route.navigate(['/books/',this.ranRoomId]);


}

}
