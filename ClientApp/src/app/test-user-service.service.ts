import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs/Observable";
import { TestUser } from "./test-user";

@Injectable()
export class TestUserServiceService {

  constructor(private httpClient: HttpClient) { }

  // Getting the list of users
  GetTestUsers(): Observable<TestUser[]> {
    return this.httpClient.get<TestUser[]>('http://localhost:50206/api/TestUsers');
  }

  // Adding a new user by calling post
  AddUser(testuser: TestUser) {
    return this.httpClient.post('http://localhost:50206/api/TestUsers', testuser);
  }

  //// Marking a video as watched using the PUT API
  //setWatched(testuser: TestUser) {
  //  testuser.watched = true;

  //  return this.httpClient.put(`/api/TestUsers/${testuser.Id}`, testuser);
  //}
}
