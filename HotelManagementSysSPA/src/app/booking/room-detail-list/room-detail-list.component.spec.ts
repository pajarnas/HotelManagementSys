import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RoomDetailListComponent } from './room-detail-list.component';

describe('RoomDetailListComponent', () => {
  let component: RoomDetailListComponent;
  let fixture: ComponentFixture<RoomDetailListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RoomDetailListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RoomDetailListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
