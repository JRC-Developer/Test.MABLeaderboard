import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html'
})
export class UserListComponent {
  public users: user[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<user[]>(baseUrl + 'users').subscribe(result => {
      this.users = result;
    }, error => console.error(error));
  }
}

interface user {
  id: number;
  firstname: string;
  lastname: string;
  email: string;
  telephone: string;
}
