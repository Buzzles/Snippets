import { Module, NestModule, MiddlewareConsumer, RequestMethod } from '@nestjs/common';

import { LoggerMiddleware } from './middleware/logger.middleware';
import { loggerFn } from './middleware/loggerfunction.middleware';

import { AppController } from './app.controller';
import { AppService } from './app.service';
import { TestModule } from './test/test.module';

@Module({
  imports: [TestModule],
  controllers: [AppController],
  providers: [AppService],
})
export class AppModule implements NestModule {
  configure(consumer: MiddlewareConsumer) {
    consumer
    // .apply(LoggerMiddleware)
    .apply(loggerFn, LoggerMiddleware)
    .forRoutes('*');
    //.forRoutes({ path: '*', method: RequestMethod.GET });
  }}