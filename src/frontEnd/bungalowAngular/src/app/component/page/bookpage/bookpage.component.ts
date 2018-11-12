import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { dateValidator } from "./datevalidate";

@Component({
  selector: 'app-bookpage',
  templateUrl: './bookpage.component.html',
  styleUrls: ['./bookpage.component.scss']
})
export class BookpageComponent implements OnInit {

  isValid = false;
  TypeAppartments: Array<any>;



  bookForm: FormGroup;

  apartmentId: FormControl;
  fname: FormControl;
  lname: FormControl;
  personalNumber: FormControl;
  startDate: FormControl;
  email: FormControl;

  constructor(private _http: HttpClient) {
    this.getAppartments();
  }

  ngOnInit() {
    this.createFormControls();
    this.createForm();
  }

  createFormControls() {
    this.apartmentId = new FormControl('', Validators.required);
    this.fname = new FormControl('', Validators.required);
    this.lname = new FormControl('', Validators.required);
    this.email = new FormControl('', [
      Validators.required,
      Validators.pattern("[^ @]*@[^ @]*")
    ]);
    this.personalNumber = new FormControl();
    this.startDate = new FormControl(new Date(), [dateValidator]);
  }

  createForm() {
    this.bookForm = new FormGroup({
      apartmentId: this.apartmentId,
      fname: this.fname,
      lname: this.lname,
      email: this.email,
      personalNumber: this.personalNumber,
      startDate: this.startDate,
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

  getAppartments() {
    this._http
      .get('https://localhost:44307/api/Booking/GetAppartmentType')
      .subscribe((x: Array<any>) => {
        console.log('result', x);
        this.TypeAppartments = x;
      });

  }


}
