import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GraphQLModule } from "./graphql.module";
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule, LOCALE_ID } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MaterialModule } from './material.module';

import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';

import { AccountDialogComponent } from './account-dialog/account-dialog.component';
import { AccountListComponent } from './account-list/account-list.component';
import { AppComponent } from './app.component';
import { CodeDialogComponent } from './code-dialog/code-dialog.component';
import { CodeListComponent } from './code-list/code-list.component';
import { ConfirmationDialogComponent } from './confirmation-dialog/confirmation-dialog.component';
import { FinancialYearDialogComponent } from './financial-year-dialog/financial-year-dialog.component';
import { FinancialYearSelectorComponent } from './financial-year-selector/financial-year-selector.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { SupplierDialogComponent } from './supplier-dialog/supplier-dialog.component';
import { SupplierListComponent } from './supplier-list/supplier-list.component';
import { ToolbarComponent } from './toolbar/toolbar.component';
import { TransactionListComponent } from './transaction-list/transaction-list.component';

@
NgModule({
  declarations: [
    AccountDialogComponent,
    AccountListComponent,
    AppComponent,
    CodeDialogComponent,
    CodeListComponent,
    ConfirmationDialogComponent,
    FinancialYearDialogComponent,
    FinancialYearSelectorComponent,
    SidebarComponent,
    SupplierDialogComponent,
    SupplierListComponent,
    ToolbarComponent,
    TransactionListComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    GraphQLModule,
    HttpClientModule,
    MaterialModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: (http: HttpClient) => new TranslateHttpLoader(http, './assets/i18n/', '.json'),
        deps: [HttpClient]
      }
    })
  ],
  entryComponents: [
    AccountDialogComponent,
    CodeDialogComponent,
    ConfirmationDialogComponent,
    FinancialYearDialogComponent,
    SupplierDialogComponent
  ],
  providers: [
    { provide: LOCALE_ID, useValue: 'nl-BE' },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
