import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-bookpage',
  templateUrl: './bookpage.component.html',
  styleUrls: ['./bookpage.component.scss']
})
export class BookpageComponent implements OnInit {
  bookForm: FormGroup;

  apartmentId: FormControl;
  typeA: FormControl;
  personalNumber: FormControl;
  startDate: FormControl;
  endDate: FormControl;

  constructor(private _http: HttpClient) {}

  ngOnInit() {
    this.createFormControls();
    this.createForm();
  }

  createFormControls() {
    this.apartmentId = new FormControl(0);
    this.typeA = new FormControl(1);
    this.personalNumber = new FormControl();
    this.startDate = new FormControl(new Date());
    this.endDate = new FormControl(new Date());
  }

  createForm() {
    this.bookForm = new FormGroup({
      apartmentId: this.apartmentId,
      typeA: this.typeA,
      personalNumber: this.personalNumber,
      startDate: this.startDate,
      endDate: this.endDate
    });
  }

  onSubmit() {
    console.log('this.bookForm.value', this.bookForm.value);
    this._http
      .post('https://localhost:44307/api/Booking', this.bookForm.value)
      .subscribe(x => {
        console.log('result', x);
      });
  }
}
