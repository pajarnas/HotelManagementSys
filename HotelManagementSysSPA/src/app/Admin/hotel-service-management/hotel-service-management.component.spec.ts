import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HotelServiceManagementComponent } from './hotel-service-management.component';

describe('HotelServiceManagementComponent', () => {
  let component: HotelServiceManagementComponent;
  let fixture: ComponentFixture<HotelServiceManagementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HotelServiceManagementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HotelServiceManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
