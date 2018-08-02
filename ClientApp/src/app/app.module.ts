import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { TestUsersListComponent } from './test-users-list/test-users-list.component';
import { AddComponent } from './add/add.component';
import { TestUserServiceService } from './test-user-service.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    TestUsersListComponent,
    AddComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: TestUsersListComponent, pathMatch: 'full' },
      { path: 'Add', component: AddComponent },
    ]),
  ],
  providers: [TestUserServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
