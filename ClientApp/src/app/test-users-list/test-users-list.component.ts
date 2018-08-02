import { Component, OnInit, Inject } from '@angular/core';
import { TestUserServiceService } from '../test-user-service.service';
import { TestUser } from "../test-user";

@Component({
  selector: 'app-test-users-list',
  templateUrl: './test-users-list.component.html',
  styleUrls: ['./test-users-list.component.css']
})
export class TestUsersListComponent implements OnInit {
  public testUsers: TestUser[];
  constructor(private testUserServiceService: TestUserServiceService) { }

  ngOnInit() {
    this.testUserServiceService.GetTestUsers()
      .subscribe(testUsers => {
        this.testUsers = testUsers;
      });
  }

}
