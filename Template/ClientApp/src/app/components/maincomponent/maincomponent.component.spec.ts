
import { fakeAsync, ComponentFixture, TestBed } from '@angular/core/testing';

import { MaincomponentComponent } from './maincomponent.component';

describe('MaincomponentComponent', () => {
  let component: MaincomponentComponent;
  let fixture: ComponentFixture<MaincomponentComponent>;

  beforeEach(fakeAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ MaincomponentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MaincomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should compile', () => {
    expect(component).toBeTruthy();
  });
});
