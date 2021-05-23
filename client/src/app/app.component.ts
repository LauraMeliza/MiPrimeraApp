import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Fredy es una gueva';
  users:any;
  constructor(private http: HttpClient){

  }
  ngOnInit(){
   this.getUsers();
    
  }
  getUsers(){
    this.http.get('https://localhost:5001/api/user').subscribe(Response => {
      this.users = Response;
    }, error => {
      console.log(error);
    });
  }
}
