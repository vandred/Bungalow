import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { dateValidator } from './datevalidate';

@Component({
  selector: 'app-bookpage',
  templateUrl: './bookpage.component.html',
  styleUrls: ['./bookpage.component.scss']
})
export class BookpageComponent implements OnInit {
  reservationNumber = '';

  TypeAppartments: Array<any>;

  bookForm: FormGroup;

  apartmentId: FormControl;
  fname: FormControl;
  lname: FormControl;
  email: FormControl;
  personalNumber: FormControl;
  startDate: FormControl;

  constructor(private _http: HttpClient) {
    this.getAppartments();
  }

  ngOnInit() {
    this.createFormControls();
    this.createForm();
  }

  createFormControls() {
    this.apartmentId = new FormControl(0, Validators.required);
    this.fname = new FormControl('', Validators.required);
    this.lname = new FormControl('', Validators.required);
    this.email = new FormControl('', [
      Validators.required,
      Validators.pattern('[^ @]*@[^ @]*')
    ]);
    this.personalNumber = new FormControl('', [
      Validators.minLength(8),
      Validators.required
    ]);
    // this.reservationNumber = new FormControl('', Validators.required);
    this.startDate = new FormControl(new Date(), [dateValidator]);
  }

  createForm() {
    this.bookForm = new FormGroup({
      apartmentId: this.apartmentId,
      fname: this.fname,
      lname: this.lname,
      email: this.email,
      personalNumber: this.personalNumber,
      // reservationNumber: this.reservationNumber,
      startDate: this.startDate
    });
  }

  onSubmit() {
    if (this.bookForm.valid) {
      console.log('form is valid so send data');
      this._http
        .post('https://localhost:44307/api/Booking/Book', this.bookForm.value)
        .subscribe((x: string) => {
          console.log('POST result', x);
        });
    }
  }

  getAppartments() {
    this._http
      .get('https://localhost:44307/api/Booking/GetAppartmentType')
      .subscribe((x: Array<any>) => {
        console.log('result', x);
        this.TypeAppartments = x;
      });
  }
}
