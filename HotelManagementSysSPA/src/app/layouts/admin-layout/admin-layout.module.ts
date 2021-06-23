import { NgModule } from '@angular/core';
import {ActivatedRoute, RouterModule} from '@angular/router';
import {CommonModule, DatePipe} from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AdminLayoutRoutes } from './admin-layout.routing';
import { DashboardComponent } from '../../dashboard/dashboard.component';
import { UserProfileComponent } from '../../user-profile/user-profile.component';

import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import {MatNativeDateModule, MatRippleModule} from '@angular/material/core';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatSelectModule} from '@angular/material/select';
import {RoomCardComponent} from "../../shared/room-card/room-card.component";
import {RoomTypeCardComponent} from "../../shared/room-type-card/room-type-card.component";
import {MatDatepickerModule} from "@angular/material/datepicker";
import { CurrencyMaskModule } from "ng2-currency-mask";
import {BookBills} from "../../booking/book-bills/book-bills";
import {BillsListComponent} from "../../shared/bills-list/bills-list.component";
import {MatCheckboxModule} from "@angular/material/checkbox";
import {RoomBookCardComponent} from "../../booking/room-book-card/room-book-card.component";
import {RoomDetailListComponent} from "../../booking/room-detail-list/room-detail-list.component";
import {AddHotelServiceComponent} from "../../Admin/add-hotel-service/add-hotel-service.component";
import {HotelServiceManagementComponent} from "../../Admin/hotel-service-management/hotel-service-management.component";
import {AvailablesComponent} from "../../room/availables/availables.component";
import {TypesComponent} from "../../room/types/types.component";
import {BookRoomComponent} from "../../room/book-room/book-room.component";
import {MiniBookCardComponent} from "../../shared/mini-book-card/mini-book-card.component";
import {RoomListComponent} from "../../shared/room-list/room-list.component";
import {AppModule} from "../../app.module";
import {BookServiceComponent} from "../../booking/book-service/book-service.component";


@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatRippleModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatTooltipModule,
    MatDatepickerModule,
    MatDatepickerModule,
    MatNativeDateModule,
    CurrencyMaskModule,
    MatCheckboxModule,


  ],
  declarations: [
    //Rooms
    AvailablesComponent,
    TypesComponent,
    BookRoomComponent,
    //Books
    BookBills,
    RoomBookCardComponent,
    RoomDetailListComponent,
    BookServiceComponent,

    //shared:
    BillsListComponent,
    MiniBookCardComponent,
    RoomCardComponent,
    RoomListComponent,
    RoomTypeCardComponent,




    AddHotelServiceComponent,



    HotelServiceManagementComponent,



    DashboardComponent,
    UserProfileComponent,



  ],
  exports: [

  ],
  providers: [MatDatepickerModule, DatePipe]
})

export class AdminLayoutModule {}
