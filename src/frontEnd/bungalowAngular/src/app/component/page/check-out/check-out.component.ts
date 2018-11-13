import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { dateValidator } from '../bookpage/datevalidate';

@Component({
  selector: 'app-check-out',
  templateUrl: './check-out.component.html',
  styleUrls: ['./check-out.component.scss']
})
export class CheckOutComponent implements OnInit {
  totalSum = '';

  cheakOutForm: FormGroup;

  reservationNumber: FormControl;
  cheakOutDate: FormControl;

  constructor(private _http: HttpClient) {}

  ngOnInit() {
    this.createFormControls();
    this.createForm();
  }

  createFormControls() {
    this.reservationNumber = new FormControl('', [
      Validators.required,
      Validators.minLength(8)
    ]);
    this.cheakOutDate = new FormControl(new Date(), [
      Validators.required,
      dateValidator
    ]);
  }

  createForm() {
    this.cheakOutForm = new FormGroup({
      reservationNumber: this.reservationNumber,
      cheakOutDate: this.cheakOutDate
    });
  }

  onSubmit() {
    console.log('this.cheakOutForm.value', this.cheakOutForm.value);

    if (this.cheakOutForm.valid) {
      this._http
        .post(
          'https://localhost:44307/api/Booking/CheckOut',
          this.cheakOutForm.value
        )
        .subscribe((x: any) => {
          console.log('check out respons', x);
          if (x != null) {
            this.totalSum = x.price;
            console.log('POST result', x);
          } else {
            this.totalSum =
              'There is no such reservation plese check you Reservation number';
          }
        });
    }
  }
}
