import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from "@angular/router";
import {RoomService} from "../core/services/RoomService";
import {RoomCardModel} from "../shared/models/RoomCardModel";
import {BookRequest} from "../shared/models/BookRequest";
import { DatePipe } from '@angular/common'
import Swal from 'sweetalert2/dist/sweetalert2.js';
import {CustomerService} from "../core/services/CustomerService";
import {HttpHeaders} from "@angular/common/http";
@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})
export class UserProfileComponent implements OnInit {

  constructor(public datepipe: DatePipe,private route: ActivatedRoute,private roomService:RoomService,private customerService:CustomerService) { }
  id:number;
  roomCard: RoomCardModel;

  bookRequest:BookRequest = <BookRequest>{};


  roomUrl = './assets/img/hotel/'+ 'default.jpg';
  baseUrl = './assets/img/hotel/';
  description = 'a standard room is likely the same as a queen or a single room, great for a solo traveler or a couple. Expect a double bed. ';
isupdating:boolean;
  ngOnInit() {


    this.route.paramMap.subscribe(
      params => {

        this.id = Number(params.get('id'));

        // call the MovieService that will call the Movie Details API.
        this.roomService.getAvailableRoomCardsById(this.id).subscribe(
          m=>{

            this.roomCard = m;
            this.bookRequest.roomNo = this.roomCard.id;
            this.populate();

          }
        );
      }
    )

  }

  book(){

      console.log(this.bookRequest);
      this.customerService.postBooking(this.bookRequest).subscribe(m=>{if(m){

      }});

    Swal.fire({
      position: 'top-end',
      icon: 'success',
      title: 'Your booking has been saved',
      showConfirmButton: false,
      timer: 1500
    })


  }




  populate() {

    switch (this.roomCard.roomTypeId) {
      case 1:
        this.roomUrl = this.baseUrl + 'low-cost0.jpg';

        break;
      case 2:
        this.roomUrl = this.baseUrl + 'low-cost0.jpg';

        this.description = 'These rooms will have space for a wheelchair to move easily, and a bathroom outfitted for a disabled person with friends.'
        break;
      case 3:
        this.roomUrl = this.baseUrl + 'medium0.jpeg';
        this.description = 'a joint room, sometimes called an adjoining room, refers to two rooms that share ' +
          'a common wall but no connecting door.'

        break;
      case 4:
        this.roomUrl = this.baseUrl + 'default.jpg';
        this.description = 'These rooms target long stay guests with full kitchens, laundry, and other amenities. Housekeeping services twice a week. '

        break;
      case 5:
        this.roomUrl = this.baseUrl + 'hight-class0.jpg';
        this.description = 'these rooms have a connecting door between them, as well as individual doors to get to the outside. For Family';
        break;
      case 6:
        this.roomUrl = this.baseUrl + 'hight-class1.jpg';
        this.description = 'These rooms might be a bit bigger with slightly upgraded amenities or a nicer view. Usually the most expensive room '
        break;
      default:
        this.roomUrl = this.baseUrl + 'default.jpg';
        this.description = 'These rooms target long stay guests with full kitchens, laundry, and other amenities. Housekeeping services twice a week. '

    }
  }
}
