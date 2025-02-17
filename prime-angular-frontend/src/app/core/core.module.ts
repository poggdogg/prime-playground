import { NgModule, Optional, SkipSelf, ErrorHandler } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HTTP_INTERCEPTORS } from '@angular/common/http';

import { throwIfAlreadyLoaded } from '@core/module-import-guard';

import { AccessDeniedComponent } from '@core/components/access-denied/access-denied.component';
import { PageNotFoundComponent } from '@core/components/page-not-found/page-not-found.component';
import { AuthHttpModule } from '@core/modules/auth-http/auth-http.module';
import { ErrorHandlerInterceptor } from '@core/interceptors/error-handler.interceptor';
import { ErrorHandlerService } from '@core/services/error-handler.service';

@NgModule({
  imports: [
    BrowserAnimationsModule,
    AuthHttpModule
  ],
  providers: [
    // TODO: move to own HttpModule
    {
      provide: ErrorHandler,
      useClass: ErrorHandlerService
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ErrorHandlerInterceptor,
      multi: true
    }
  ],
  declarations: [
    AccessDeniedComponent,
    PageNotFoundComponent
  ],
  exports: [
    PageNotFoundComponent,
    AccessDeniedComponent
  ]
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    throwIfAlreadyLoaded(parentModule, 'CoreModule');
  }
}
