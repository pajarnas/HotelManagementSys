import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MiniAdminTableComponent } from './mini-admin-table.component';

describe('MiniAdminTableComponent', () => {
  let component: MiniAdminTableComponent;
  let fixture: ComponentFixture<MiniAdminTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MiniAdminTableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MiniAdminTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
