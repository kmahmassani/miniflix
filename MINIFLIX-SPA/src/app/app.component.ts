import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'MINIFLIX-SPA';
  constructor(private http: HttpClient) {}

  ngOnInit() {
    // debugger;
    // this.http.get('http://localhost:5000/api/values').subscribe(response => {
    //   console.log(response);
    // });
  }
}
