import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'
import { TestUserServiceService } from '../test-user-service.service';
import { TestUser } from "../test-user";

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent {
  public testuser: TestUser;
  constructor(private router: Router, private testuserservice : TestUserServiceService) { }

  AddUser() {
    this.testuserservice.AddUser(this.testuser)
      // The subscribe method here adds a listener to the asynchronous add
      // operation and the listener is called once the video is added.
      // Here, we are switching to the video list page after adding the video
      .subscribe(() => {
        this.router.navigateByUrl('/');
      });
  }

}
