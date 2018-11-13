import { FormControl } from '@angular/forms';

export function dateValidator(control: FormControl) {
  let value: Date;
  value = new Date(control.value);
  let nowDate = new Date();

  if (value > nowDate) {
    return null;
  } else {
    return {
      dateValidator: {
        valid: false
      }
    };
  }
}
