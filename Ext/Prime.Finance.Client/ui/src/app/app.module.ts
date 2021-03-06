import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { NgModule } from '@angular/core';
import { MaterialModule } from "./material.module";

import { AppComponent } from './app.component';
import { ExchangesComponent } from './exchanges/exchanges.component';
import { ToolbarComponent } from './toolbar/toolbar.component';
import { ExchangeComponent } from './exchange/exchange.component';
import { ExchangeDialogComponent } from './exchange-dialog/exchange-dialog.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { LoggerService } from './services/logger.service';
import { WsClientService } from './services/ws-client.service';
import { PrimeSocketService } from './services/prime-socket.service';
import { FilterPipe } from './pipes/filter.pipe';
import { ChartComponent } from './chart/chart.component';
import { ChartService } from './services/chart.service';
import { PricingComponent } from './pricing/pricing.component';
import { FileTransferComponent } from './file-transfer/file-transfer.component';

@NgModule({
  declarations: [
    AppComponent,
    ExchangesComponent,
    ToolbarComponent,
    ExchangeComponent,
    ExchangeDialogComponent,
    FilterPipe,
    ChartComponent,
    PricingComponent,
    FileTransferComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
  ],
  providers: [
    LoggerService,
    {provide: "ISocketClient", useClass: WsClientService},
    PrimeSocketService,
    ChartService
  ],
  entryComponents: [
    ExchangeDialogComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
