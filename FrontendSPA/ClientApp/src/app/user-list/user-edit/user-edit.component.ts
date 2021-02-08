import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from "@angular/router";
import { Router } from "@angular/router"

@Component({
  selector: 'app-user-edit',
  templateUrl: './user-edit.component.html'
})
export class UserEditComponent {
  public id: number;
  public firstname: string;
  public lastname: string;
  public email: string;
  public telephone: string;
  private apiBaseUrl: string;

  constructor(private router: Router, private route: ActivatedRoute, private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiBaseUrl = baseUrl;
    http.get<user>(baseUrl + 'users/' + this.route.snapshot.paramMap.get("id")).subscribe(result => {
      this.id = result.id;
      this.firstname = result.firstname;
      this.lastname = result.lastname;
      this.email = result.email;
      this.telephone = result.telephone;
    }, error => console.error(error));
  }

  editUser() {
    const headers = { 'content-type': 'application/json' }
    const body = "";
    const requestUrl = this.apiBaseUrl + 'users/' + this.id + '/' + this.firstname + '/' + this.lastname + '/' + this.email + '/' + this.telephone;
    this.http.post<updateResponse>(requestUrl, body, { 'headers': headers }).subscribe(result => {
      const response = result;
      console.log(result);
      if (response.success)
        this.router.navigate(['/user-list']);
      else
        console.log("Failed!");
    })
  }
}

interface user {
  id: number;
  firstname: string;
  lastname: string;
  email: string;
  telephone: string;
}

interface updateResponse {
  success: boolean;
  errormessage: string;
}
