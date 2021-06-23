import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MiniBookCardComponent } from './mini-book-card.component';

describe('MiniBookCardComponent', () => {
  let component: MiniBookCardComponent;
  let fixture: ComponentFixture<MiniBookCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MiniBookCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MiniBookCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
