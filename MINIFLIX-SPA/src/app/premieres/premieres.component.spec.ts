/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PremieresComponent } from './premieres.component';

describe('PremieresComponent', () => {
  let component: PremieresComponent;
  let fixture: ComponentFixture<PremieresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PremieresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PremieresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
