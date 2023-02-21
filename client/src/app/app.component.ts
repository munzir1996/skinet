import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent implements OnInit {

  title = 'Skinet';
  products: any[];

  constructor(
    private http: HttpClient) {

    }

  ngOnInit(): void {
    this.http.get("https://localhost:44339/api/Products?Sort=priceAsc&Search=t").subscribe((response: any) => {
      console.log(response);
      this.products = response.data;
    }, error => {
      console.log(error);

    })
  }

}
