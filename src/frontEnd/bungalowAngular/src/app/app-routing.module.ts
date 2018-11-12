import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookpageComponent } from './component/page/bookpage/bookpage.component';
import { CheckOutComponent } from './component/page/check-out/check-out.component';

const routes: Routes = [
  { path: '', component: BookpageComponent },
{ path: 'checkout', component: CheckOutComponent },];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
