import { Routes } from '@angular/router';

import { DashboardComponent } from '../../dashboard/dashboard.component';
import { UserProfileComponent } from '../../user-profile/user-profile.component';


import {RoomBookCardComponent} from "../../booking/room-book-card/room-book-card.component";
import {BookBills} from "../../booking/book-bills/book-bills";
import {RoomListComponent} from "../../shared/room-list/room-list.component";
import {RoomDetailListComponent} from "../../booking/room-detail-list/room-detail-list.component";
import {AvailablesComponent} from "../../room/availables/availables.component";
import {TypesComponent} from "../../room/types/types.component";
import {BookServiceComponent} from "../../booking/book-service/book-service.component";
import {HotelServiceManagementComponent} from "../../Admin/hotel-service-management/hotel-service-management.component";


export const AdminLayoutRoutes: Routes = [

    { path: '',      component: AvailablesComponent },

    { path: 'rooms',      component: AvailablesComponent },
    { path: 'rooms/types', component:TypesComponent},
  { path: 'rooms/availables',component:AvailablesComponent},
  { path: 'rooms/availables/:id',component:AvailablesComponent},

  { path: 'books',component:RoomBookCardComponent},
  { path: 'books/:id',component:UserProfileComponent},
  { path: 'books/bills/:id',component:BookBills},

  { path: 'books/details/:id', component:RoomDetailListComponent},
  { path: 'books/services/:id', component:BookServiceComponent},
  { path: 'admin', component:HotelServiceManagementComponent},

];
