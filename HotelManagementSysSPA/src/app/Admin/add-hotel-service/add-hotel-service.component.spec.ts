import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddHotelServiceComponent } from './add-hotel-service.component';

describe('AddHotelServiceComponent', () => {
  let component: AddHotelServiceComponent;
  let fixture: ComponentFixture<AddHotelServiceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddHotelServiceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddHotelServiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
