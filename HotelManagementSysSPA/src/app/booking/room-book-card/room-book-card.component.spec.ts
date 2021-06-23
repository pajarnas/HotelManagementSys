import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RoomBookCardComponent } from './room-book-card.component';

describe('RoomBookCardComponent', () => {
  let component: RoomBookCardComponent;
  let fixture: ComponentFixture<RoomBookCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RoomBookCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RoomBookCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
