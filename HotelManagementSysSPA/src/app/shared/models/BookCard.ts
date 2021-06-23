

  export interface ServicesBooked {
    serviceDate: Date;
    serviceDesc: string;
    servicePrice: number;
    serviceId: number;
  }

  export interface BookCard {
    roomType: string;
    roomId: number;
    checkInDates: Date;
    rent:number,
    customerName: string;
    totalBill: number;
    roomTypeId:number;
    serviceNumbers: number;
    bookingDays: number;
    servicesBooked: ServicesBooked[];
  }



