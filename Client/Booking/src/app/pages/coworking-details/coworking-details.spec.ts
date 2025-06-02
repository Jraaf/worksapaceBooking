import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CoworkingDetails } from './coworking-details';

describe('CoworkingDetails', () => {
  let component: CoworkingDetails;
  let fixture: ComponentFixture<CoworkingDetails>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CoworkingDetails]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CoworkingDetails);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
