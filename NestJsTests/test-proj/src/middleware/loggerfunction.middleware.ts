import { Request, Response, NextFunction } from 'express';

export function loggerFn(req: Request, res: Response, next: NextFunction) {
    console.log(`Request...`);
    res.setHeader("loggerFn", "lolheader from loggerFn");    
    next();
  };