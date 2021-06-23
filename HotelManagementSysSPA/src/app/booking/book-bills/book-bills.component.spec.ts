import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookBills } from './book-bills';

describe('BookDetailListComponent', () => {
  let component: BookBills;
  let fixture: ComponentFixture<BookBills>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookBills ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BookBills);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
