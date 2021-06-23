import { Component, OnInit } from '@angular/core';

declare const $: any;
declare interface RouteInfo {
  path: string;
  title: string;
  icon: string;
  class: string;
}
export const ROUTES: RouteInfo[] = [
  { path: '/rooms/types', title: 'Rooms Types',  icon: 'local_hotel', class: '' },
  { path: 'rooms/availables', title: 'Available Rooms',  icon: 'dashboard', class: '' },

  { path: 'books', title: 'Books',  icon: 'widgets', class: '' },
  { path: 'admin', title: 'Admin',  icon: 'admin_panel_settings', class: '' },

];

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
  menuItems: any[];

  constructor() { }

  ngOnInit() {
    this.menuItems = ROUTES.filter(menuItem => menuItem);
  }
  isMobileMenu() {
    if ($(window).width() > 991) {
      return false;
    }
    return true;
  };
}
