import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestUsersListComponent } from './test-users-list.component';

describe('TestUsersListComponent', () => {
  let component: TestUsersListComponent;
  let fixture: ComponentFixture<TestUsersListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestUsersListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestUsersListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
